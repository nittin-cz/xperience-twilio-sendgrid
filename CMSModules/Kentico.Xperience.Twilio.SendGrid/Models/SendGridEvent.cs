﻿using Newtonsoft.Json;

namespace Kentico.Xperience.Twilio.SendGrid.Models
{
    /// <summary>
    /// Represents a SendGrid webhook event.
    /// </summary>
    /// <remarks>See <see href="https://docs.sendgrid.com/for-developers/tracking-events/event"/>.</remarks>
    public class SendGridEvent
    {
        /// <summary>
        /// The Xperience newsletter issue ID.
        /// </summary>
        [JsonProperty(PropertyName = "X-CMS-IssueID")]
        public string IssueId
        {
            get;
            set;
        }


        /// <summary>
        /// The Xperience newsletter subscriber ID.
        /// </summary>
        [JsonProperty(PropertyName = "X-CMS-SubscriberID")]
        public string SubscriberId
        {
            get;
            set;
        }


        /// <summary>
        /// The email address of the recipient.
        /// </summary>
        public string Email
        {
            get;
            set;
        }


        /// <summary>
        /// The UNIX timestamp of when the message was sent.
        /// </summary>
        public long Timestamp
        {
            get;
            set;
        }


        /// <summary>
        /// The unique ID attached to the message by the originating system.
        /// </summary>
        [JsonProperty(PropertyName = "smtp-id")]
        public string SmtpId
        {
            get;
            set;
        }


        /// <summary>
        /// The event type.
        /// </summary>
        public string Event
        {
            get;
            set;
        }


        /// <summary>
        /// Indicates whether a bounce <see cref="Event"/> was a hard bounce (bounce) or block (blocked).
        /// </summary>
        public string Type
        {
            get;
            set;
        }


        /// <summary>
        /// The categories of the message.
        /// </summary>
        public string Category
        {
            get;
            set;
        }


        /// <summary>
        /// A unique ID to this event that you can use for deduplication purposes. These IDs are up to 100 characters long and are URL safe.
        /// </summary>
        [JsonProperty(PropertyName = "sg_event_id")]
        public string EventId
        {
            get;
            set;
        }


        /// <summary>
        /// The unique, internal SendGrid ID for the message. The first half of this ID is pulled from the <see cref="SmtpId"/>. The message
        /// ID will be included in most cases. In the event of an asynchronous bounce, the message ID will not be available.
        /// </summary>
        [JsonProperty(PropertyName = "sg_message_id")]
        public string MessageId
        {
            get;
            set;
        }


        /// <summary>
        /// Indicates whether or not an open event has been generated by Apple Mail Privacy Protection (MPP). When this field is set to true,
        /// it means that SendGrid has received signals indicating that a recipient with MPP enabled has triggered an open event. When this field is
        /// false, it indicates that the event was triggered by a conventional open.
        /// </summary>
        [JsonProperty(PropertyName = "sg_machine_open")]
        public bool SgMachineOpen
        {
            get;
            set;
        }


        /// <summary>
        /// The IP address used to send the email. For open and click events, it is the IP address of the recipient who engaged with the email.
        /// </summary>
        public string Ip
        {
            get;
            set;
        }


        /// <summary>
        /// The full text of the HTTP response error returned from the receiving server.
        /// </summary>
        public string Response
        {
            get;
            set;
        }


        /// <summary>
        /// The number of times SendGrid has attempted to deliver this message.
        /// </summary>
        public string Attempt
        {
            get;
            set;
        }


        /// <summary>
        /// The user agent responsible for the event. This is usually a web browser.
        /// </summary>
        public string UserAgent
        {
            get;
            set;
        }


        /// <summary>
        /// The URL where the event originates. For click events, this is the URL clicked on by the recipient.
        /// </summary>
        public string Url
        {
            get;
            set;
        }


        /// <summary>
        /// Indicates whether TLS encryption was used in sending this message.
        /// </summary>
        public bool Tls
        {
            get;
            set;
        }


        /// <summary>
        /// If there is more than one of the same links in an email, this tells you which of those identical links was clicked.
        /// </summary>
        [JsonProperty(PropertyName = "url_offset")]
        public int UrlOffset
        {
            get;
            set;
        }


        /// <summary>
        /// Status code string. Corresponds to HTTP status code - for example, a JSON response of 5.0.0 is the same as a 500 error response.
        /// </summary>
        public string Status
        {
            get;
            set;
        }


        /// <summary>
        /// The ID of the unsubscribe group the recipient's email address is included in. ASM IDs correspond to the ID that is returned when
        /// you create an unsubscribe group.
        /// </summary>
        [JsonProperty(PropertyName = "asm_group_id")]
        public int AsmGroupId
        {
            get;
            set;
        }


        /// <summary>
        /// For emails sent with a specified IP Pool, you can view the IP Pool in the event data for a processed event.
        /// </summary>
        public SendGridEventPool Pool
        {
            get;
            set;
        }
    }
}