using System.ComponentModel;

namespace Bible.Application.Enums;
public enum UploadType : byte
{
    [Description(@"Images\Products")]
    Product,

    [Description(@"Images\ProfilePictures")]
    ProfilePicture,

    [Description(@"Documents")]
    Document
}