using System;
using System.IO;
using System.Windows.Documents;

namespace WPF15._10
{
    internal class XpsDocument
    {
        private string fileName;
        private FileAccess read;

        public XpsDocument(string fileName, FileAccess read)
        {
            this.fileName = fileName;
            this.read = read;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal IDocumentPaginatorSource GetFixedDocumentSequence()
        {
            throw new NotImplementedException();
        }
    }
}