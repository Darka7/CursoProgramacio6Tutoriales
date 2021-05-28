﻿using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BD
{
    public interface IDataAccess
    {
        Task<DBEntity> ExecuteAsync(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<dynamic>> QueryAsync(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<A>> QueryAsync<A, B, C, D, E, H, I>(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<A>> QueryAsync<A, B, C, D, E, H>(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<A>> QueryAsync<A, B, C, D, E>(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<A>> QueryAsync<A, B, C, D>(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<A>> QueryAsync<A, B, C>(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<A>> QueryAsync<A, B>(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T>(string sp, object Param = null, int? Timeout = null);
        Task<T> QueryFirstAsync<T>(string sp, object Param = null, int? Timeout = null);
    }
}