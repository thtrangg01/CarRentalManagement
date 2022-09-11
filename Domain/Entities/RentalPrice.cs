using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table(name: "rental_pricce")]
    public class RentalPrice : BaseEntity
    {
        public int CarId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public double MeterLimit { get; set; }

        public RentalPriceKeyCode KeyCode { get; set; }

        [Required]
        public decimal Rate { get; set; }

        public CarEntity CarEntity { get; set; }

        public RentalPrice(int carId, string title, double meterLimit, RentalPriceKeyCode keyCode, decimal rate)
        {
            CarId = carId;
            Title = title;
            MeterLimit = meterLimit;
            KeyCode = keyCode;
            Rate = rate;
        }

        public RentalPrice()
        {
        }

        public RentalPriceQty ToRentalPriceQty()
        {
            return new RentalPriceQty()
            {
                CarId = CarId,
                Title = Title,
                KeyCode = KeyCode,
                MeterLimit = MeterLimit,
                Rate = Rate,
                Quantity = 0,
            };
        }
    }
}
