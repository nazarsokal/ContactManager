using AutoMapper;
using ContactManager.DTO;
using ContactManager.Models;

namespace ContactManager.Mapper;

public class ContactProfile : Profile
{
    public ContactProfile()
    {
        CreateMap<GetContactDto, Contact>();
        CreateMap<Contact, GetContactDto>();
        CreateMap<List<GetContactDto>, List<Contact>>();
        CreateMap<List<Contact>, List<GetContactDto>>();
        
        CreateMap<UploadContactDto, PostContactDto>()
            .ForMember(dest => dest.ContactId, opt => Guid.NewGuid());
        
        CreateMap<PostContactDto, Contact>();
    }
}