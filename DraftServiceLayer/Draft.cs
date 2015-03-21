//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DraftServiceLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Draft
    {
        public int DraftId { get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public int Player3Id { get; set; }
        public int Player4Id { get; set; }
        public int Player5Id { get; set; }
        public Nullable<int> Player6Id { get; set; }
        public Nullable<int> Player7Id { get; set; }
        public Nullable<int> Player8Id { get; set; }
        public int Set1Id { get; set; }
        public int Set2Id { get; set; }
        public int Set3Id { get; set; }
        public Nullable<int> WinnerId { get; set; }
        public System.DateTime DraftDate { get; set; }
    
        public virtual Player Player1 { get; set; }
        public virtual Player Player2 { get; set; }
        public virtual Player Player3 { get; set; }
        public virtual Player Player4 { get; set; }
        public virtual Player Player5 { get; set; }
        public virtual Player Player6 { get; set; }
        public virtual Player Player7 { get; set; }
        public virtual Player Player8 { get; set; }
        public virtual MagicSet MagicSet1 { get; set; }
        public virtual MagicSet MagicSet2 { get; set; }
        public virtual MagicSet MagicSet3 { get; set; }
        public virtual Player Winner { get; set; }
    }
}