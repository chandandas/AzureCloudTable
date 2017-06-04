﻿/*
using System.Collections.Generic;
using System.Linq;

namespace Sample
{
    using Microsoft.WindowsAzure.Storage;
    using Microsoft.WindowsAzure.Storage.Auth;

    public class UserRepository
    {
        private const string AccountKey = "YourAccountKey";

        private const string AccountName = "YourAccountName";

        /*This is used as a dummy object to give access to the property names of a User type.
         *If the User class was static, then there would be no need for this.
         *This gets used in the constructor with the extension method called "GetPropertyName".#1#
        private readonly User _tempUserInstance = new User();

        private PartitionSchema<User> _usersInFloridaPartitionSchema;
        private PartitionSchema<User> _userVersionPartitionSchema;
        private PartitionSchema<User> _userTypePartitionSchema;
        private PartitionSchema<User> _firstNamePartitionSchema;

        //One could possibly make this a public property to give direct query access. Of course
        //that sort of defeats the purpose of a repository but, hey, nobody's looking.
        public CloudTableContext<User> UserContext;

        public UserRepository()
        {
            var storageCredentials = new StorageCredentials(AccountName, AccountKey);
            var storageAccount = new CloudStorageAccount(storageCredentials, true);
            UserContext = new CloudTableContext<User>(storageAccount, "UserId");
            // UserContext.UseBackgroundTaskForIndexing = false;

            InitPartitionSchemas();
        }

        /// <summary>
        /// The partition schemas are how your domain object gets sorted/categorized/grouped inside Azure Table
        /// storage. You create them in your client code and then "add" them to the CloudTableContext class
        /// that you're using to interact with the Table (in this case _userContext). 
        /// Remember, these are just schema definitions for one particular PartitionKey.
        /// 
        /// There is a DefaultSchema that get set on the CloudTableContext class automatically (in this case _userContext)
        /// which sets the PartitionKey to be the name of the object Type and the RowKey based on the Id property of the object
        /// provided during intialization.
        /// </summary>
        private void InitPartitionSchemas()
        {
            _usersInFloridaPartitionSchema = UserContext.CreatePartitionSchema()
                                                        .SetPartitionKey("UsersInFlorida")
                                                        .SetSchemaCriteria(user => user.UserAddress.State == "FL")
                /*The RowKey is set to the ID property by default, which in this case is the user.UserId#1#
                                                        .SetIndexedPropertyCriteria(user => user.UserAddress.State);

            _firstNamePartitionSchema = UserContext.CreatePartitionSchema()
                                                   .SetPartitionKey("FirstName")
                                                   .SetSchemaCriteria(user => true)
                /*The RowKey is set to the ID property by default, which in this case is the user.UserId#1#
                                                   .SetIndexedPropertyCriteria(user => user.FirstName);

            _userTypePartitionSchema = UserContext.CreatePartitionSchema()
                                                  .SetPartitionKey("UserTypePartition")
                                                  .SetSchemaCriteria(user => true)
                /*The RowKey is set to the ID property by default, which in this case is the user.UserId#1#
                                                  .SetIndexedPropertyCriteria(user => user.GetType().Name);

            _userVersionPartitionSchema = UserContext.CreatePartitionSchema()
                                                     .SetPartitionKey("UserVersionPartition")
                                                     .SetSchemaCriteria(user => true)
                                                     .SetRowKeyCriteria(user => UserContext.GetChronologicalBasedRowKey())
                /*In this case we're keeping a version log so we want a new 
                                                                                       RowKey created upon each write to the Table#1#
                                                     .SetIndexedPropertyCriteria(user => user.UserId);

            // Now add the schemas that were just created to the CloudTableContext<User> instance (i.e. _userContext).
            UserContext.AddMultiplePartitionSchemas(new List<PartitionSchema<User>>
            {
                _usersInFloridaPartitionSchema,
                _firstNamePartitionSchema,
                _userTypePartitionSchema,
                _userVersionPartitionSchema
            });
        }

        public List<User> GetAllUsers()
        {
            return UserContext.GetByDefaultSchema().ToList();
        }

        public void Save(User user)
        {
            UserContext.InsertOrReplace(user);
        }

        /*public void Save(Admin adminUser) { _userContext.InsertOrReplace(adminUser); }#1#

        public void Save(User[] users)
        {
            UserContext.InsertOrReplace(users);
        }

        public List<User> GetUsersThatLiveInFlorida()
        {
            return UserContext.GetByPartitionKey(_usersInFloridaPartitionSchema.PartitionKey).ToList();
        }

        public IEnumerable<User> GetUsersByFirstName(string firstName)
        {
            return UserContext.GetByIndexedProperty(_firstNamePartitionSchema.PartitionKey, firstName).ToList();
        }

        public List<User> GetUsersByTypeOfUser(string userType)
        {
            return UserContext.GetByIndexedProperty(_userTypePartitionSchema.PartitionKey, userType).ToList();
        }

    public IEnumerable<User> GetAllVersions(User givenUser)
        {
            return UserContext.GetByIndexedProperty(_userVersionPartitionSchema.PartitionKey, _userVersionPartitionSchema.GetIndexedPropertyFromCriteria(givenUser));
        }
    }
}
*/
