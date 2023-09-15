namespace VeganCounter.Models.DTOs.StandartUserDtos
{
    public class StandartUserCreateDto : StandartUserBaseDto
    {
        public string PasswordConfirm { get; set; }
        public DateTime CreatedDate => DateTime.Now;
    }
}
