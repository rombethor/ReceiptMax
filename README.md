# ReceiptMax
A component process for templating and sending receipts to any thermal receipt printer.

## Creating a template

First a template must be created by inheriting the `TicketDocument` class and overwriting the `Ticket` method:

```
public MyTicketDocument : TicketDocument
{
  protected override PrintPageEventArgs Ticket(object sender)
  { /*...*/ }
}
```

The template can then be elaborated with the given helper methods:

`WriteCenteredLine("Title", font)` will write the text "Title" with the given font.

`WriteWrappedLine("Longer text...", font)` will write the text wrapped with the given font.

`DrawImage(filename)` will draw an image onto the print area.

## Printing the ticket

Create a new `TicketPrinter` object as 
`var ticketPrinter = new TicketPrinter();`

`ticketPrinter.GetAvailablePrinters()` will provide a list of available printers.  These are the names of the printers to be used in referencing them.

Then print the `TicketDocument` implementation by referencing the name of the printer:
`ticketPrinter.Print(new MyTicketDocument(), printerName);`


## Example

For a full example, see the "TestApplication" project in this solution.

## Future Updates

Currently I am looking to implement tabled information into this project and have it read the template from an XML file.
I am, however, under to no pressure to finish it soon...
