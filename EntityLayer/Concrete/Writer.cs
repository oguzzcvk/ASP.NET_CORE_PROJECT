﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
  public class Writer
  {
    [Key]
    public int WriterId { get; set; }
    public string WriterName { get; set; }
    public string WriterAbout { get; set; }
    public string WriterImage { get; set; }
    public string WriterMail { get; set; }
    public string WriterPassword { get; set; }
    public string RepeatPassword { get; set; }
    public bool Status { get; set; }
    public List<Blog> Blogs { get; set; }

    public virtual ICollection<Message2> WriterSender { get; set; }
    public virtual ICollection<Message2> WriterReceiver { get; set; }
  }
}
