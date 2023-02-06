namespace AbstractVEInterface
{
    public abstract class Document
    {
        /*
         * Sunucuda tutulan, üzerinde çeşitli işlemler yapılabilen  Excel, Word ya da PDF dokümanları
         */

        public string Title { get; set; }


        public void Copy(string from, string to)
        {
            Console.WriteLine($"{from} adresinden {to} adresine kopyalandı");
        }
        public void ChangeDocumentTitle(string newTitle)
        {
            Title = newTitle;
        }

        public abstract void Save();
        public abstract void Open();
        //public virtual void Print() { }
    }

    public interface IPrintable
    {
        void Print();
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        //public  void Print()
        //{
        //    throw new NotImplementedException();
        //}

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        //public  void Print()
        //{
        //    throw new NotImplementedException();
        //}

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class PDFDocument : Document
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }



        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class PrinterComponent
    {
        public void Print(IPrintable document)
        {
            //document.Print();
            document.Print();
        }
    }




}
