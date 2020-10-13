using System;
using System.Collections.Generic;
using DAL;
using Model;

namespace BLL
{
    public class AddressBLL
    {
        AddressDAL dAL = new AddressDAL();
        //显示
        public List<Address> GetList()
        {
            return dAL.GetList();
        }
    }
}
