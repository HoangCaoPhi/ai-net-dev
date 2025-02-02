# How generative AI and LLMs work

Tất cả các Generative AI đều được xây dựng dựa trên các model.

Generative AI là một loại AI có khả năng tạo ra nội dung gốc như: ngôn ngữ tự nhiên, hình ảnh, âm thanh và code.

Generative AI models sử dụng mẫu đã xác định trong training data để tạo mới nội dung tương tự về mặt thống kê.

Kết quả của một generative AI dựa trên input được cung cấp bởi user. Một cách phổ biến cho user tương tác với generative AI thông qua ứng dụng chat bằng cách sử dụng ngôn ngữ tự nhiên làm input. 

Đầu tiên, dữ liệu đầu vào sẽ được parsed thành dạng dữ liệu để model có thể hiểu được. Sau đó, model sử dụng dữ liệu đó để xác định mẫu phù hợp từ quá trình training sau đó kết hợp để xây dựng kết quả đầu ra sau cùng. Generative AI models được thiết kế để tạo ra nội dung duy nhất, vì vậy chúng không tạo ra cùng kết quả cho một output cho các input giống hệt nhau.

Generative AI sử dụng LLMs để hỗ trợ input đầu vào và ouput đầu ra là ngôn ngữ tự nhiên. LLM thực hiện các tác vụ xử lý ngôn ngữ tự nhiên (NLP) như phân loại văn bản và xác định cảm xúc (sentiment analysis) của nội dung đầu vào. 

Quy trình xử lý đầu vào:
- Phân loại và phân tích cảm xúc (sentiment): LLM sẽ phân tích văn bản đầu vào, xác định thể loại của nội dung và cảm xúc liên quan (ví dụ: tích cực, tiêu cực hay trung tính).
- Nhận dạng mẫu: Kết quả phân loại và phân tích cảm xúc (sentiment) này giúp mô hình AI nhận diện các mẫu (pattern) và cấu trúc cần thiết để tạo ra đầu ra phù hợp.

Quá trình tạo đầu ra:
- Nếu đầu ra là văn bản: LLM có thể tự mình tạo ra văn bản đầu ra dựa trên thông tin đã phân tích.
- Nếu đầu ra là âm thanh hoặc hình ảnh: Bên cạnh LLM, các mô hình chuyên biệt khác được sử dụng để xử lý dữ liệu và cung cấp các mẫu cần thiết nhằm tạo ra đầu ra dạng âm thanh hoặc hình ảnh.

# Common uses of generative AI

### Natural language generation

Một vài Generative AI có thể tạo ra output là ngôn ngữ tự nhiên như là:
- AI có thể tạo ra các tóm tắt hồ sơ LinkedIn được viết chuyên nghiệp
- AI có thể tạo ra các mô tả chi tiết và hấp dẫn cho sản phẩm trên cửa hàng trực tuyến
- AI có thể gợi ý các ý tưởng cho bữa ăn lành mạnh
- vv...

### Image generation

Một vài Generative AI có thể tạo ra output là hình ảnh từ ngôn ngữ tự nhiên là input. Ví dụ:
- Những người hoặc cái gì đó xuất hiện trong ảnh
- Phong cách nghệ thuật để tạo hình ảnh
- Tham khảo để tạo ra các hình ảnh tương tự
- vv..

### Audio generation
Một vài Generative AI có thể tạo ra đầu ra dạng âm thanh (audio) từ các đầu vào bằng ngôn ngữ tự nhiên. 

- Tổng hợp giọng nói tự nhiên từ văn bản
- Tạo nhạc theo phong cách cụ thể hoặc sử dụng các nhạc cụ nhất định
- Chỉnh sửa các tập tin âm thanh đầu vào dựa trên tiêu chí được cung cấp bằng ngôn ngữ tự nhiên

### Code generation
Tạo ra code lập trình từ các đầu vào bằng ngôn ngữ tự nhiên. :
-  Viết bằng ngôn ngữ mà người dùng lựa chọn
- Chấp nhận một cấu trúc đầu vào và đầu ra cụ thể
- Sử dụng các công nghệ cụ thể dựa trên tài liệu tham khảo

# How LLMs work

Trước khi đưa văn bản vào huấn luyện, toàn bộ văn bản được chia thành các đơn vị nhỏ hơn gọi là tokens. Mỗi token đại diện cho một giá trị văn bản duy nhất. Một token có thể là một từ đầy đủ, hoặc có thể là một phần của từ (đặc biệt trong các ngôn ngữ sử dụng các từ ghép hoặc các từ phức tạp), thậm chí, token có thể là sự kết hợp của các từ và dấu câu. Mỗi token sau khi được xác định sẽ được gán cho một số nhận dạng duy nhất (ID). Quá trình này giúp chuyển đổi văn bản từ dạng chuỗi ký tự thành một chuỗi các số (token IDs), làm cho dữ liệu có thể được xử lý bởi mô hình học máy.

Sau khi tách văn bản thành các token, mỗi token sẽ được gán một vector ngữ cảnh, gọi là embedding. Đây là một vector số gồm nhiều giá trị, trong đó mỗi phần tử của vector thể hiện một thuộc tính ngữ nghĩa cụ thể của token đó. Các phần tử trong vector của token được xác định dựa trên tần suất và cách thức token đó xuất hiện cùng nhau hoặc trong các ngữ cảnh tương tự. Nghĩa là, nếu hai token thường xuất hiện cùng nhau hoặc trong những ngữ cảnh có ý nghĩa tương tự, thì các vector của chúng sẽ có những giá trị tương đồng.

Mục tiêu của mô hình là dự đoán token tiếp theo dựa trên các token đã có trong chuỗi (các token trước đó). Mỗi token trong chuỗi được gán một trọng số (weight), trọng số này biểu thị mức độ ảnh hưởng của token đó đối với việc dự đoán token tiếp theo, các token có trọng số càng cao có ảnh hưởng lớn hơn đến kết quả dự đoán. Các embedding vectors (vector ngữ cảnh) của các token cùng với trọng số của chúng được sử dụng để thực hiện một phép tính, phép tính này nhằm dự đoán giá trị vector cho token tiếp theo dựa trên các token hiện có. Sau khi tính toán ra được vector dự đoán cho token tiếp theo, mô hình sẽ so sánh với các vector đã học để xác định token nào có khả năng xảy ra cao nhất dựa trên vector dự đoán. Token có khả năng cao nhất sẽ được chọn để tiếp tục chuỗi.

Mỗi khi một token được dự đoán và thêm vào chuỗi đầu ra, chuỗi mới này sẽ trở thành đầu vào cho bước dự đoán tiếp theo. Quá trình này được lặp lại cho đến khi toàn bộ chuỗi đầu ra hoàn thiện. Mô hình không tạo ra toàn bộ câu hoặc đoạn văn cùng một lúc, mà thay vào đó, nó xây dựng đầu ra bằng cách dự đoán và thêm từng token một cách liên tục. Tương tự như khi sử dụng tính năng tự động hoàn thành trên điện thoại hoặc trình duyệt, mô hình đưa ra các gợi ý dựa trên những gì đã được gõ vào trước đó. Mỗi khi người dùng nhập thêm ký tự, các gợi ý sẽ được cập nhật dựa trên đầu vào mới, giống như cách mô hình cập nhật dự đoán của mình sau mỗi token được thêm vào.

Trong quá trình huấn luyện, mô hình có toàn bộ dữ liệu văn bản dưới dạng một chuỗi các token. Tuy nhiên, tại mỗi bước huấn luyện, mô hình chỉ tập trung vào một token tại một thời điểm, và bỏ qua tất cả các token phía sau token đang xét để mô phỏng quá trình dự đoán. Mô hình sử dụng các token trước đó để dự đoán vector của token tiếp theo, sau khi mô hình đưa ra dự đoán, giá trị vector dự đoán được so sánh với giá trị thực tế của token tiếp theo trong dữ liệu huấn luyện. Loss (độ lỗi) là sự khác biệt giữa giá trị dự đoán và giá trị thực tế. Một hàm mất mát (loss function), chẳng hạn như Cross-Entropy Loss, được sử dụng để định lượng mức độ sai lệch giữa dự đoán của mô hình và thực tế. Dựa trên giá trị loss, thuật toán tối ưu hóa (optimizer), như Stochastic Gradient Descent (SGD) hoặc Adam, sẽ điều chỉnh trọng số (weights) của mô hình. Mục tiêu là giảm dần loss qua nhiều vòng huấn luyện để mô hình có thể đưa ra dự đoán chính xác hơn theo thời gian.




