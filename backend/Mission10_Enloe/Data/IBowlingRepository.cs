namespace Mission10_Enloe.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<BowlerDTO> GetBowlerDTOs();
    }
}
