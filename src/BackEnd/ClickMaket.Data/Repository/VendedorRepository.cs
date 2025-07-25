﻿using ClickMarket.Business.Interfaces;
using ClickMarket.Business.Models;
using ClickMarket.Data.Context;

namespace ClickMarket.Data.Repository
{
    public class VendedorRepository : Repository<Vendedor>, IVendedorRepository
    {
        public VendedorRepository(ClickDbContext clickDbContext) : base(clickDbContext)
        {

        }
    }
}
