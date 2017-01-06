using Amazon.S3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AWSDotNet45.Controllers
{
    public class BucketsController : ApiController
    {
        private IAmazonS3 S3Client;

        public BucketsController()
        {
            this.S3Client = new Amazon.S3.AmazonS3Client();
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var buckets = S3Client.ListBucketsAsync();

            return buckets.Result.Buckets.Select(x => x.BucketName);
        }
    }
}
