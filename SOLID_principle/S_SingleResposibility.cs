namespace Test.SOLID_principle
{
    public class S_SingleResponsibility
    {
        // Mỗi class chỉ nên có một lý do để thay đổi
        // Một class chỉ nên đảm nhận một nhiệm vụ duy nhất

        // Ví dụ
        // Lớp chỉ xử lý thông tin người dùng
        public class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }

        // Lớp xử lý việc lưu trữ
        public class UserRepository
        {
            public void Save(User user)
            {
                // lưu user vào database
            }
        }

        // Sai
        // public class User
        // {
        //     public string Name { get; set; }
        //     public string Email { get; set; }

        //     public void Save() // Không nên
        //     {
        //         // Không nên tự lưu vào database
        //     }
        // }
    }
}