﻿namespace Mixer.Base.Model.User
{
    /// <summary>
    /// A fully populater user with channel, preferences, groups and private details.
    /// </summary>
    public class PrivateUserModel : UserModel
    {
        /// <summary>
        /// The users password.
        /// </summary>
        public string password { get; set; }
    }
}
