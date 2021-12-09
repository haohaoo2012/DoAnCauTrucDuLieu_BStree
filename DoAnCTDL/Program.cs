using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoAnCTDL
{
   public class Program
    {
        static void Main(string[] args)
        {
           
            Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.Clear();

		
			Console.Write("Cây nhị phân tìm kiếm \n");
			BSTree tree = new BSTree();
			tree.insert(new Node(new Product(18, "Hub 4.0", 180, 1,"Chậm")));
			tree.insert(new Node(new Product(20, "Ram DDR4", 980, 5, "tốc dộ xử lí nhanh")));
			tree.insert(new Node(new Product(10, "SSD 256gb", 1000, 5, "Nhanh, rẻ")));
			tree.insert(new Node(new Product(15, "HDD 1T", 560, 4, "Ổn định")));
			tree.insert(new Node(new Product(12, "VGA NVIDIA", 3800, 4, "Ngon")));
			tree.insert(new Node(new Product(17, "USB 16gb", 250, 3, "Xịn xò")));
			tree.insert(new Node(new Product(7, "Laptop Dell Vostro 5490", 18000, 4, "Máy đẹp")));
		    tree.insert(new Node(new Product(9, "laptop Lenovo Thinkpad T14", 21000, 4, "Máy mạnh")));
			tree.insert(new Node(new Product(8, "Surface Pro 3", 15000, 3, "máy yếu")));
			tree.insert(new Node(new Product(3, "Logitech Mouse", 480, 3, "Giá ổn")));


            //Hiển thị
            tree.TraversePreOrder(); // N L R
            tree.TraversetInOrder(); // L N R
            tree.TraversePostOrder(); // L R N


            //Xóa

            tree.delete(10);
            tree.TraversePreOrder(); // L + R
            

            //Tìm kiếm
            int productid = 3;
            Node node = tree.search(productid);
            if (node == null)
            {
                Console.WriteLine("\n\nKhông có kết quả tìm kiếm. Xin vui lòng thử lại! \n");
            }
            else
            {
                Console.WriteLine("\n\n-------------------------Kết quả tìm kiếm sản phẩm có Id = " + productid);
                node.Data();
            }

        }

    }
}
