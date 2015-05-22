namespace Domain
{
    using System;

    public class InvalidMailException : Exception { }
    public class InvalidNameException : Exception { }
    public class InvalidPhoneException : Exception { }

    public class TooLongDescriptionException : Exception { }
    public class InvalidArtistNameException : Exception { }
    public class InvalidMinimumBidException : Exception { }

    public class MemberAlreadyRegisterException : Exception { }
    public class SameArtItemIdException : Exception { }

    public class InvalidMemberException : Exception { }
    public class InvalidCredentialsException : Exception { }

    public class SameAuctionIdException : Exception { }
    public class InvalidStartDateException : Exception { }
    public class InvalidEndDateException : Exception { }

    public class ImageInvalidException : Exception { }

    public class NonExistingAuctionException : Exception { }
    public class NonExistingArtitemException : Exception { }

    public class ArtItemNotInRangeException : Exception { }
}
