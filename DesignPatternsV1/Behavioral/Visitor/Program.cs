using System;
using System.Collections.Generic;

namespace DesignPatternsV1.Behavioral.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a document processor
            var documentProcessor = new DocumentProcessor();

            // Add documents to process
            documentProcessor.AddDocument(new ConcreteComponentA());
            documentProcessor.AddDocument(new ConcreteComponentB());

            // Process documents with different processors
            Console.WriteLine("Processing documents with Visitor 1:");
            documentProcessor.ProcessDocuments(new ConcreteVisitor1());

            Console.WriteLine("\nProcessing documents with Visitor 2:");
            documentProcessor.ProcessDocuments(new ConcreteVisitor2());

            // Clear documents
            documentProcessor.ClearDocuments();
        }
    }
} 