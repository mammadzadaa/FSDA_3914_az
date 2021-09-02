namespace EF_Intro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20)]
        public string Number { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(16)]
        public string CartNumber { get; set; }

        [StringLength(30)]
        public string Adress { get; set; }
    }
}
