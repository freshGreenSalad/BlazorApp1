namespace BlazorApp1.Client.common.services.FormService
{
    public interface IFormService
    {
        Task GetForms();

        Task PostForms();
    }
}
