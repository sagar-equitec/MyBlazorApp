﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.Models
{
    public partial class UserContext
    {
        private IUserContextProcedures _procedures;

        public virtual IUserContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new UserContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public IUserContextProcedures GetProcedures()
        {
            return Procedures;
        }

        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetAllUsersResult>().HasNoKey().ToView(null);
        }
    }

    public partial class UserContextProcedures : IUserContextProcedures
    {
        private readonly UserContext _context;

        public UserContextProcedures(UserContext context)
        {
            _context = context;
        }

        public virtual async Task<List<GetAllUsersResult>> GetAllUsersAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<GetAllUsersResult>("EXEC @returnValue = [dbo].[GetAllUsers]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
