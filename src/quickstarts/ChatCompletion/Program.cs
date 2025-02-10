using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

IKernelBuilder kernelBuilder = Kernel.CreateBuilder();

#pragma warning disable SKEXP0070
kernelBuilder.AddOllamaChatCompletion(
    modelId: "phi3",
    endpoint: new Uri("http://localhost:11434"));

Kernel kernel = kernelBuilder.Build();

IChatCompletionService chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();

ChatHistory chatHistory = [];
chatHistory.AddUserMessage("Hello, how are you today?");

var response = await chatCompletionService.GetChatMessageContentAsync(chatHistory,
    kernel: kernel);

// For non-streaming
Console.WriteLine(response);

// For streaming
var responseStreaming = chatCompletionService.GetStreamingChatMessageContentsAsync(
    chatHistory: chatHistory,
    kernel: kernel
);

await foreach (var chunk in responseStreaming)
{
    Console.Write(chunk);
}