﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23DH112807_MyStore.Models.ViewModel
{
    public class ProductSearchVM
    {
        //tiêu chí để search theo tên, mô tả sp
        // hoặc loại sản phẩm
        public string SearchTerm { get; set; }
        public List<Product> Products { get; set; }
    }
}

        //các tiêu chí để search theo giá
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        //danh sách sản phẩm thỏa điều kiện tìm kiếm
        public List<Product> Products { get; set; }
    }
}

        //Thứ tự sắp xếp
        public string SortOrder { get; set; }

        //Các thuộc tính hỗ trợ phân trang
        public int PageNumber { get; set; } //trang hiện tại
        public int PageSize { get; set; } = 10; //số sản phẩm mỗi trang

        //Danh sách sản phẩm đã phân trang
        public PagedList.IPagedList<Product> Products { get; set; }

        //Danh sách sản phẩm thỏa điều kiện tìm kiếm
        // public List<Product> Products {get;set;}
    }

}