using System;
using System.Collections.Generic;

namespace DesignPatternsV1.Behavioral.Visitor
{
    public class DocumentProcessor
    {
        private List<IComponent> _documents;

        public DocumentProcessor()
        {
            _documents = new List<IComponent>();
        }

        public void AddDocument(IComponent document)
        {
            _documents.Add(document);
        }

        public void ProcessDocuments(IVisitor processor)
        {
            Console.WriteLine("Processing documents...");
            Client.ClientCode(_documents, processor);
        }

        public void ClearDocuments()
        {
            _documents.Clear();
        }
    }
} 