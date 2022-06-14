using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Rubik.Models;

namespace Rubik.Models
{
    public class GioHang
    {
        RubikStoreContext data = new RubikStoreContext();
        public int id { get; set; }
        [Display(Name ="Tên")]
        public string ten { get; set; }
        [Display(Name ="Ảnh bìa")]
        public string hinh { get; set; }
        [Display(Name ="Giá Bán")]
        public double gia { get; set; }
        [Display(Name = "Số lượng")]
        public int iSoluong { get; set; }
        [Display(Name = "Thành Tiền")]
        public double dThanhtien
        {
            get { return iSoluong * gia; }
        }
        public GioHang(int id)
        {
            this.id = id;
            Rubik rubik = data.Rubiks.Single(n => n.id == id);
            ten = rubik.ten;
            hinh = rubik.hinh;
            gia = double.Parse(rubik.gia.ToString());
            iSoluong = 1;
        }
    }
}