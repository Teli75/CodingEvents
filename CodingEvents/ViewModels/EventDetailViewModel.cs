using System;
using System.Collections.Generic;
using CodingEvents.Models;

namespace CodingEvents.ViewModels
{
    public class EventDetailViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string CategoryName { get; set; }
        public string TagText { get; set; }
        public int EventId { get; set; }

        public EventDetailViewModel(Event theEvent)
        {

            Name = theEvent.Name;
            Description = theEvent.Description;
            ContactEmail = theEvent.ContactEmail;
            CategoryName = theEvent.Category.Name;
            EventId = theEvent.Id;

            TagText ="";
            List<Tag> evtTags = theEvent.Tags.ToList();

            for (var i=0; i < evtTags.Count; i++)
            {
                TagText += ("#" + evtTags[i].Name);
                if (i <evtTags.Count - 1)
                {
                    TagText += ", "; 
                }
            }
        }
    }
}