﻿namespace VrRetreat.Core
{
    public interface IVrChat
    {
        Task InitializeAsync();
        Task<bool> GetPlayerExistsAsync(string username);
    }
}
