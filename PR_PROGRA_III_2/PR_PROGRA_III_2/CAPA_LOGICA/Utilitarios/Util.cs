using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace CAPA_ENTIDADES.Utilitarios
{
    public class Util
    {
        /// <summary>
        /// Convierte el tipo image de sql en una imagen
        /// </summary>
        /// <param name="img1"></param>
        /// <returns></returns>
        public static Bitmap ConvertirImagen(byte[] img1)
        {
            byte[] img = img1;
            MemoryStream str = new MemoryStream();
            str.Write(img, 0, img.Length);
            Bitmap bit = new Bitmap(str);
            return bit;
        }

        /// <summary>
        /// Convierte el tipo imagen en un array de bytes
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static byte[] ConvertirImagenAByte(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Convierte una cadena texto a un cifrado Hash
        /// </summary>
        /// <param name="rawData"></param>
        /// <returns></returns>
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// Convierte una cadena texto en un codigo QR
        /// </summary>
        /// <param name="info"></param>
        /// <returns>Retorna una imagen del codigo QR</returns>
        public static Image GenerarQR(string info)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(info, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            return code.GetGraphic(5);
        }

        /// <summary>
        /// Convierte una imagen QR en texto
        /// </summary>
        /// <param name="qrCode"></param>
        /// <returns>Retorna la informacion de una Imagen QR</returns>
        public static string DecodificarQR(Image qrCode)
        {
            Bitmap bitmap = new Bitmap(qrCode);

            BarcodeReader reader = new BarcodeReader { AutoRotate = true, TryInverted = true };
            Result result = reader.Decode(bitmap);
            string decoded = result.ToString().Trim();

            return decoded;
        }

        /// <summary>
        /// Genera un string aleatorio
        /// </summary>
        /// <returns>Un token aleatorio para generar el codigo QR</returns>
        public static string GenerarToken()
        {
            int longitud = 7;
            Guid miGuid = Guid.NewGuid();
            string token = Convert.ToBase64String(miGuid.ToByteArray());
            token = token.Replace("=", "").Replace("+", "");
            return token.Substring(0, longitud);
        }

        /// <summary>
        /// Cambia el tamaño de una imagen
        /// </summary>
        /// <param name="image">La imagen</param>
        /// <param name="width">El nuevo ancho de la imagen</param>
        /// <param name="height">El nuevo largo de la imagen</param>
        /// <returns>Retorna la imagen con el tamaño cambiado</returns>
        public static Image CambiarTamanoImagen(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return (Image) destImage;
        }

    }
}
