﻿using DependencyInversionPrinciple.Classes;

Book book = new Book(new ConsolePrinter());
book.Print();
book.Printer = new HtmlPrinter();
book.Print();