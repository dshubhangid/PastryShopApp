using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PastryShopApp.Models
{
  
        public class Order
        {
            [BindNever]
            public int OrderId { get; set; }
            public List<OrderDetail> OrderDetails { get; set; }

            [Required(ErrorMessage = "Please enter your first name")]
            [Display(Name = "First Name")]
            [StringLength(50)]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "Please enter your last name")]
            [Display(Name = "Last Name")]
            [StringLength(50)]
            public string LastName { get; set; }

            [Required(ErrorMessage = "Please enter your address")]
            [Display(Name = "Address Line ")]
            [StringLength(100)]

            public string AddressLine { get; set; }

           

            [Required(ErrorMessage = "Enter your zip code")]
            [Display(Name = "Zip Code")]
            [StringLength(10, MinimumLength = 4)]
            public string ZipCode { get; set; }

            [Required(ErrorMessage = "Enter your city")]
            [StringLength(50)]
            public string City { get; set; }
            public string State { get; set; }

            [Required(ErrorMessage = "Enter your country")]
            [StringLength(50)]
            public string Country { get; set; }

            [Required(ErrorMessage = "Please enter your phone number")]
            [Display(Name = "Phone Number")]
            [DataType(DataType.PhoneNumber)]
            [StringLength(25)]
            public string PhoneNumber { get; set; }


            [Required(ErrorMessage = "Please enter your email")]
            [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address")]
            [StringLength(50)]
            public string Email { get; set; }

            [Column(TypeName = "decimal(18,2)")]
            [BindNever]
            [ScaffoldColumn(false)]
            public decimal OrderTotal { get; set; }

            [ScaffoldColumn(false)]
            public DateTime OrderPlaced { get; set; }

        }


    }

