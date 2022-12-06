using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using A_DAL.IRepositories;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQlDoanhThuServices
    {
        List<ViewDoanhThuNhanVien> Getlistviewdoanhthu();
    }
}
