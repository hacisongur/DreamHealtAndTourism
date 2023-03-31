
using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomId { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Numarasını Giriniz!")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Görseli giriniz!")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz!")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Başlığı Bilgisi Giriniz!")]
        [StringLength(100,ErrorMessage ="Lütfen en fazla 100 karekter giriniz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz!")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen Banyo sayısı giriniz!")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen Açıklamayı Yazınız!")]
        public string Description { get; set; }
    }
}
