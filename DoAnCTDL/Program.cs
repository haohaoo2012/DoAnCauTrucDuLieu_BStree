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


            Console.Write("Cây nhị phân tìm kiếm với sản phẩm \n");
            BSTree tree = new BSTree();
            tree.insert(new Node(new Product(18, "Hub 4.0", 180, 1, "Chậm")));
            tree.insert(new Node(new Product(20, "Ram DDR4", 980, 5, "tốc dộ xử lí nhanh")));
            tree.insert(new Node(new Product(10, "SSD 256gb", 1000, 5, "Nhanh, rẻ")));
            tree.insert(new Node(new Product(15, "HDD 1T", 560, 4, "Ổn định")));
            tree.insert(new Node(new Product(12, "VGA NVIDIA", 3800, 4, "Ngon")));
            tree.insert(new Node(new Product(17, "USB 16gb", 250, 3, "Xịn xò")));
            tree.insert(new Node(new Product(7, "Laptop Dell Vostro 5490", 18000, 4, "Máy đẹp")));
            // tree.insert(new Node(new Product(9, "laptop Lenovo Thinkpad T14", 21000, 4, "Máy mạnh")));
            tree.insert(new Node(new Product(8, "Surface Pro 3", 15000, 3, "máy yếu")));
            tree.insert(new Node(new Product(3, "Logitech Mouse", 480, 3, "Giá ổn")));

            Console.WriteLine("| 1 - Insert   |\n| 2 - Traverse |\n| 3 - Find     |\n| 4 - Remove   |\n| 5 - DepthTree|\n| 0 - Exit     |");
            for (; ; )
            {
                Console.Write("\n---Hoạt động :");
                string sel = Console.ReadLine();
                string _id;
                int _Id;
                string _Productname;
                string _price;
                int _Price;
                string _rating;
                int _Rating;
                string _Des;
                switch (sel)
                {
                    case "1":
                        Console.Write("Nhập lần lượt thông tin sản phẩm cần thêm: ");
                        Console.Write("\nId = ");
                        _id = Console.ReadLine();
                        _Id = int.Parse(_id);
                        Console.Write("Product Name = ");
                        _Productname = Console.ReadLine();
                        Console.Write("Product Price = ");
                        _price = Console.ReadLine();
                        _Price = int.Parse(_price);
                        Console.Write("Product Rating = ");
                        _rating = Console.ReadLine();
                        _Rating = int.Parse(_rating);
                        Console.Write("Product Description = ");
                        _Des = Console.ReadLine();
                        tree.insert(new Node(new Product(_Id, _Productname, _Price, _Rating, _Des)));
                        continue;
                    case "2":
                        try
                        {
                            Console.WriteLine("Tổng số nút có trên cây là: " + tree.numNodesIn());
                            Console.WriteLine("Tổng số cạnh có trên cây là: " + tree.numEdgesIn());
                            Console.WriteLine("Chọn phương pháp duyệt cây:");
                            Console.Write("1 -- Inorder\n2 -- Preorder\n3 -- Postorder\n");
                            Console.Write("Phương pháp: ");
                            sel = Console.ReadLine();
                            switch (sel)
                            {
                                case "1":
                                    tree.TraversetInOrder();
                                    break;
                                case "2":
                                    tree.TraversePreOrder();
                                    break;
                                case "3":
                                    tree.TraversePostOrder();
                                    break;
                                default:
                                    Console.WriteLine("Sai số, hãy thử lại");
                                    continue;
                            }
                            continue;
                        }
                        catch
                        {
                            Console.WriteLine("Không tồn tại cây");
                            continue;
                        }
                    case "3":
                        try
                        {
                            Console.Write("Id sản phẩm cần tìm : ");
                            _id = Console.ReadLine();
                            _Id = int.Parse(_id);
                            Node node = tree.search(_Id);
                            if (node == null)
                            {
                                Console.WriteLine("\n\nKhông có kết quả tìm kiếm. Xin vui lòng thử lại! \n");
                            }
                            else
                            {
                                Console.WriteLine("\n\n---Kết quả tìm kiếm sản phẩm có Id = " + _Id);
                                node.Data();
                            }
                            continue;
                        }
                        catch
                        {
                            Console.WriteLine("\n\nKhông có kết quả tìm kiếm. Xin vui lòng thử lại! \n");
                            continue;
                        }
                    case "4":
                        try
                        {
                            Console.Write("Id sản phẩm cần xóa: ");
                            _id = Console.ReadLine();
                            _Id = int.Parse(_id);
                            Node node = tree.search(_Id);
                            if (node == null)
                            {
                                Console.WriteLine("\n\nKhông có kết quả. Xin vui lòng thử lại! \n");
                            }
                            else
                            {
                                tree.delete(_Id);
                                Console.WriteLine("\n\n---Đã xóa sản phẩm có Id = " + _Id);
                             //Xóa trên Preorder
                                //tree.TraversePreOrder();
                             //Xóa trên Postorder
                                //tree.TraversePostOrder();
                             //Xóa trên Inorder
                                tree.TraversetInOrder();
                            }
                            continue;
                        }
                        catch
                        {
                            Console.WriteLine("\n\nKhông có kết quả tìm kiếm. Xin vui lòng thử lại! \n");
                            continue;
                        }
                    case "5":
                        {
                            Console.Write("Độ sâu lớn nhất của cây là: " + tree.maxDepth());
                            Console.Write("\nĐộ sâu nhỏ nhất của cây là: " + tree.minDepth());
                            break;
                        }
                    case "0":
                        Environment.Exit(0);
                        continue;
                    default:
                        Console.WriteLine("Không có hoạt động này vui lòng chọn số khác!");
                        break;
                }
            }
        }

    }
}

