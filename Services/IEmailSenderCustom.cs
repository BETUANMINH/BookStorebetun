namespace BookShoppingCartMVC.Services
{
    public interface IEmailSenderCustom
    {
        Task SendEmailConfirmRegister(string emailreceive, string content, string namereceive);
    }
}
