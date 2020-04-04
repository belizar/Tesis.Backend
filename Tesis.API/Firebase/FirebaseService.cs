using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tesis.API.Firebase
{
    public class FirebaseService : IFirebaseService
    {
        public readonly FirebaseApp App;

        public FirebaseService()
        {
            App = FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromJson(@"{
                                                          ""type"": ""service_account"",
                                                          ""project_id"": ""tesis-213dc"",
                                                          ""private_key_id"": ""e0900e65af27e05fc16fc0788ff2f8d97c671342"",
                                                          ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQDZdaOIBJ87GkMP\nP1EMcr06Bb/PMmGM91S0mAk8GeT++F6ONM0WOxzhE6BgCQF2xeP0lElXRyN76/ou\ngjTCYeYmBdlyScDAWebJD14uy1uxV4XsdW9y1CV4d8fBc3Y78TNsT6gG5WM5qTvP\nOhIvtHc3XDB2Vb6b/MqR7yR5vs/SVH6yjYOso62/iUO/OIhEXtEJ2PYLcnnZm3F9\nRBJ20j43vk80oK8zNYHfq0vbC7PlaEhUjkbAsENEJ6HXGXZUCRv22CFR76J4MTma\njIclVlkZOUiVPfL3MCVl+xONWAh/uClRsjNc3o+L0Slf8wD16XgB846/jZ2hfnoj\nzFwMTCDfAgMBAAECggEACV7QVSQd2GYhTZ7k1yx6iu2EfmElYvWlaMLEYxqai4IY\nUPhlffe+HtTBrGG29m9Ai2F4Z5JhLQ3WEfr6WwXs7OaDoDEdZSx6jV9kJ5ALu3CS\nDMZirwgFNVOz/9oB1kNme9xS2Tk5NVrdgOh3sCaOnIwUaoT3WbFi6Tbs03Itclqt\nX6UbXYcnTXZckFOfl6dGEBUbDLJydeXbLm6VgmAqCCxhyC6Kwxd/P5kSn/lSeFbr\njrUsW2rDjpAXv3Kd8NoYLYJ/Kav4PBoGdrsLvW5mQE2mEzWPyyim27cXacEBJXTg\nVqx4aWLx9iWYPdAVIi+0wlSb1KqqUd9OOXX0Hj4kQQKBgQD3VvXF1Im47c0qxfYr\nPRGhI5SFlnUTsWUfZfmkzjMlAXqpfTxvAAoAF8Qpt45lVLxFjR70mPy5ivcCEh4f\nmzpT7kab+WbiLmRbm+uRIx2Ec12NTZB5ztqEcNV82uPxSCDyIX3fqCDoGZQ95NTm\nnitKLKaE3HyNGlOl8WtjCLvq5QKBgQDhEti84U0CLgxpl1atOuT2qoM/tE9spxh9\nNwpAm8dPkoKQRYD+DrRcJuBnqgVs35gTrIkmlr0PCs7foTtk6WTOmKStlHFfGnTi\nRwNdq7pPU45H5LgUSadlGCSUcd8owwK/NNhO0uU8vbNGjH5KAEdW/FaiEOQxefdU\nfWwSBBVscwKBgE2AAvyc7xZx9MJ9SvgbZ4W9N1FwZnjoMc5XzpRUQ/RJdVzcL+57\n7aY/zChiKo0XsvJ8GIH92dptb55HfQbcRbd8xsUirZkbfjiyL2rHvPz+hQa8khOI\nvDGZhVtc3uWAe0pDMkS9UqpHMYr/Q7KLRvcz7G1fBOvVnvY1Ijfiybb9AoGASFxU\nzjTpG0BOwUvklAERR7R+SebgeiAmoWsmoqryo0SJMXUHCacUmWPuVaW15NDmBb08\nwulHkyR4ajFd9Q2MWVd96kiFQnwxA+as0Fq7pXFJlxeTjwI3DSt75zXM9z/rDCoj\nOQRYqvSaRJ46o/P++5pZB/XCR53cxI8mRYyGjr0CgYA/9ToZuc9DOhQp1hsl6wiF\nef/YZ/IbPZSRTFIFrnNeHVhy7KIPpachrpLF55Fvz2EWJDFzbv5Z/ZNi2R89OsEQ\n5j91CKqHQWLh5xK7zQQuqFbAhzs1ym7yuWUEXUAcwE6sF/+qXc38TXH3T4RDyLlO\nnAMn9UW/FAgUqNfKH1x3NA==\n-----END PRIVATE KEY-----\n"",
                                                          ""client_email"": ""firebase-adminsdk-84vml@tesis-213dc.iam.gserviceaccount.com"",
                                                          ""client_id"": ""105785186837370968737"",
                                                          ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
                                                          ""token_uri"": ""https://oauth2.googleapis.com/token"",
                                                          ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
                                                          ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-84vml%40tesis-213dc.iam.gserviceaccount.com""
                                                        }
                                                        ")
            });
        }
    }
}
