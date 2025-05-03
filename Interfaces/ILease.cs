﻿using System;

    public interface  ILease
    {
        int PropertyID { get; set; }
        int TenantID { get; set; }
        String Description { get; set; }
        DateTime DateLeaseStarts { get; set; }
        DateTime DateLeaseEnds { get; set; }
        decimal MonthlyRate { get; set; }
        String Notes { get; set; }
        
    }
