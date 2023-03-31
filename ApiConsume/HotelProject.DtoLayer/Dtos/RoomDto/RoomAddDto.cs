using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage ="Lütfen Oda Numarasını Giriniz!")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage ="Lütfen fiyat bilgisi giriniz!")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Başlığı Bilgisi Giriniz!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz!")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen Banyo sayısı giriniz!")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
