using AtataSamples.ConfirmationPopups;
using AtataUITests1;
using _ = SampleProject.PageObjectModel.ProductsPage;

namespace SampleProject.PageObjectModel
{
    public class ProductsPage : Page<_>
    {
        public H1<_> Header { get; private set; }
        public Table<ProductTableRow,_> Products { get; private set; }

        public class ProductTableRow : TableRow<_>
        {
            public Text<_> Name { get; private set; }
            public Currency<_> Price { get; private set; }
            public Number<_> Amount { get; private set; }

            [CloseConfirmBox]
            [FindByContent("Delete Using JS Confirm")]
            public Button<_> DeleteUsingJSConfirm { get; private set; }

            [FindByContent("Delete Using BS Modal")]
            [ConfirmDeletionViaBSModal]
            public ButtonDelegate<_> DeleteUsingBSModel { get; private set; }
            [FindByContent("Delete Using jquery-confirm")]
            [ConfirmDeletionViaJQueryConfirmBox]
            public ButtonDelegate<_> DeleteUsingJQuery { get; private set; }

        }
    }
}
