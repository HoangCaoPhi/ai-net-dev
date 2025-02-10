Ý nghĩa:
- Semantic Kernel SDK giúp đơn giản hóa việc tích hợp các tính năng AI vào các ứng dụng hiện có. Điều này đảm bảo các ứng dụng trong doanh nghiệp có thể hoạt động như một giải pháp thống nhất và toàn diện.
- SDK này giảm bớt độ phức tạp khi làm việc với nhiều mô hình AI hoặc dịch vụ AI khác nhau bằng cách cung cấp các lớp trừu tượng. Nhờ đó, nhà phát triển không cần phải hiểu chi tiết hoạt động của từng mô hình AI mà vẫn có thể sử dụng chúng hiệu quả.
- SDK giúp cải thiện độ tin cậy bằng cách: 
    - Giảm tính bất ổn của các phản hồi từ mô hình AI.
    - Cho phép tinh chỉnh các câu lệnh nhắc (prompts) và lập kế hoạch thực hiện các tác vụ.
    - Tạo ra trải nghiệm người dùng có kiểm soát và dự đoán được.

Một số core concepts:
- Connections: Là các interfaces dùng để kết nối với các dịch vụ AI và nguồn dữ liệu bên ngoài.
- Plugins: là các hàm chức năng được đóng gói, có thể sử dụng trực tiếp trong ứng dụng.
- Planner: là thành phần dùng để điều phối kế hoạch thực thi và chiến lược dựa trên hành vi người dùng.
- Memory: là một lớp trừu tượng để quản lý và đơn giản hóa việc xử lý ngữ cảnh trong các ứng dụng AI.

## Connections

Connectors hoạt động như cầu nối giữa mã nguồn ứng dụng và các mô hình AI hoặc service. Semantic Kernel xử lý các vấn đề liên quan đến kết nối và các thách thức kỹ thuật giúp cho bạn tập trung xây dựng workflows và features của riêng bạn.

## Plugins

Đóng gói các hàm ngôn ngữ tiêu chuẩn đề các ứng dụng và AI model có thể sử dụng. Nhà phát triển có thể tự tạo plugin. 

Có hai loại plugin:
- Semantic Functions: Chức năng sử dụng mô hình AI để thực hiện các nhiệm vụ như tóm tắt văn bản, dịch thuật, hoặc phân tích nội dung.

- Native Functions: Chức năng thuần túy C#, được dùng để xử lý các logic truyền thống không yêu cầu mô hình AI, như tính toán số học hoặc xử lý tệp.
 
## Planner

Planner là một thành phần cốt lõi của Semantic Kernel, được thiết kế để quản lý và điều phối các tác vụ AI một cách hiệu quả.

Đảm bảo sự phối hợp liền mạch giữa AI models và plugins.

Planner:
- Planner phân tích yêu cầu từ người dùng và lập kế hoạch để đạt được mục tiêu.

- Planner xác định và kích hoạt các plugin cần thiết để hoàn thành các tác vụ phức tạp.

- Sử dụng sức mạnh của AI để tự động hóa quá trình lập kế hoạch và điều phối, giảm sự phức tạp cho nhà phát triển.

## Memory



