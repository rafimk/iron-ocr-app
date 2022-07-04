using IronOcr;


IronOcr.Installation.LicenseKey = "IRONOCR.MUHAMMEDRAFI.25471-C879E2A119-AY2TLCJJTRVVZBTO-ANHYKASJJ6UE-73FT6HQ2X4M3-Y3I5BU6222CY-BLX44CBUGGED-PHPCSF-TOEYUNLBHRGGUA-DEPLOYMENT.TRIAL-SMEASW.TRIAL.EXPIRES.03.AUG.2022";

Console.WriteLine("---------------------------------------------------");

var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory + "\\", "Set1-A.jpg"));

var Ocr = new IronTesseract();
using (var Input = new OcrInput()){
    Input.AddImage(fileName);
    //... you can add any number of images
    var Result = Ocr.Read(Input);
    Console.WriteLine(Result.Text);
}

Console.WriteLine("---------------------------------------------------");
