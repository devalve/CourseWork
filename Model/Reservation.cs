﻿namespace CourseWork.Model
{
    public class Reservation
    {

        public int Id { get; set; }
        public int GridColumn { get; set; }
        public int GridRow { get; set; }
        public string Page { get; set; }
        public string User { get; set; }

        public string? Members { get; set; }
    }
}