using System;
using System.Collections.Generic;

namespace turboazAzureHometask.Models;

public partial class Car
{
    public int Id { get; set; }

    public string? Model { get; set; }

    public string? Vendor { get; set; }

    public int Year { get; set; }

    public double Price { get; set; }

    public string? ImageUrl { get; set; }

    public DateTime CreatedTime { get; set; }

    public DateTime ModifiedTime { get; set; }
}
