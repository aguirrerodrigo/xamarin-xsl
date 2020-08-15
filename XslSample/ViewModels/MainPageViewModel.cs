using XslSample.Services;

namespace XslSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private IDocumentService documentService;

        private string content;
        public string Content
        {
            get { return this.content; }
            set
            {
                this.content = value;
                RaisePropertyChanged();
            }
        }

        public MainPageViewModel(IDocumentService documentService)
        {
            this.documentService = documentService;

            Init();
        }

        private async void Init()
        {
            this.Content = await this.documentService.GetAsync();
        }
    }
}
