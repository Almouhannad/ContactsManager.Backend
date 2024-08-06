namespace ContactsManager.API.Models.DTO
{
    public class EditRequest
    {
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public string Phone { get; set; } = null!;
        public bool? Favorite { get; set; }

        public Contact ToDomainModel(int id)
        {
            Contact domainModel = new Contact();
            domainModel.Id = id;
            domainModel.Name = Name;
            domainModel.Email = Email;
            domainModel.Phone = Phone;
            domainModel.Favorite = Favorite != null && (bool)Favorite;
            // If Favorite is null then false (Default value) else Favorite value

            return domainModel;
        }
    }
}
