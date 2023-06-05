using System;
using Microsoft.Maui.Platform;

namespace Lossless.Domain.Entities
{
    public class Image
    {
        private int Id { get; set; }
        private double Size { get; set; }
        private string FileName { get; set; }
        private string FileType { get; set; }
        private int Likes { get; set; }
    }
}

