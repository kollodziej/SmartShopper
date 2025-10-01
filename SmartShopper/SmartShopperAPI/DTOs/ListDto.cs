public class ListDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<ListItemDto> Items { get; set; }
}