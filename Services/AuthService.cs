using System;

using System.Collections.Generic;

using System.Linq;

using DeskWise.Models;



namespace DeskWise.Services

{

    // In-memory user accounts: login, CRUD, and role checks backed by deskwise.json.

    public static class AuthService

    {

        private static List<User> _users = new List<User>();



        // Read-only view of all users in memory.

        public static IReadOnlyList<User> All

        {

            get { return _users; }

        }



        // Points the in-memory list at the store's Users collection.

        public static void BindFromStore()

        {

            _users = DataStoreService.Store.Users ?? new List<User>();

            DataStoreService.Store.Users = _users;

        }



        // Copies the in-memory list back into the store model before save.

        public static void SyncToStore()

        {

            DataStoreService.Store.Users = _users;

        }



        // Writes users to the store and flushes deskwise.json.

        public static void Save()

        {

            SyncToStore();

            DataStoreService.Save();

        }



        // Validates credentials and records last login when successful.

        public static User Login(string username, string password)

        {

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))

            {

                return null;

            }

            User matchedUser = _users.FirstOrDefault(user =>

                string.Equals(user.Username, username, StringComparison.OrdinalIgnoreCase) &&

                user.Password == password &&

                user.IsActive);

            if (matchedUser != null)

            {

                matchedUser.LastLogin = DateTime.Now;

                Save();

            }

            return matchedUser;

        }



        // Finds a user by username (case-insensitive).

        public static User GetByUsername(string username)

        {

            return _users.FirstOrDefault(user =>

                string.Equals(user.Username, username, StringComparison.OrdinalIgnoreCase));

        }



        // Adds a new user if the username is not already taken.

        public static void Add(User user)

        {

            if (GetByUsername(user.Username) != null)

            {

                throw new InvalidOperationException("Username already exists.");

            }

            _users.Add(user);

            Save();

        }



        // Replaces an existing user matched by username.

        public static void Update(User user)

        {

            int index = _users.FindIndex(item =>

                string.Equals(item.Username, user.Username, StringComparison.OrdinalIgnoreCase));

            if (index >= 0)

            {

                _users[index] = user;

                Save();

            }

        }



        // Removes a user by username.

        public static void Delete(string username)

        {

            _users.RemoveAll(user =>

                string.Equals(user.Username, username, StringComparison.OrdinalIgnoreCase));

            Save();

        }



        // True when the user has the Admin role.

        public static bool IsAdmin(User user)

        {

            return user != null && user.Role == "Admin";

        }



        // True when the user is a Manager or Admin.

        public static bool IsManager(User user)

        {

            return user != null && (user.Role == "Manager" || user.Role == "Admin");

        }



        // True when the user exists and is marked active.

        public static bool IsEmployee(User user)

        {

            return user != null && user.IsActive;

        }

    }

}


