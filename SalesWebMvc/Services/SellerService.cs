﻿using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> Findall()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller s)
        {
            s.Department = _context.Department.First();
            _context.Add(s);
            _context.SaveChanges();
        }
    }
}
