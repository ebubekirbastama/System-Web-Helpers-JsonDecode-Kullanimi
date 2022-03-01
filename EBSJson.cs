private void Vericekk()
{
    var ss = Json.Decode(veritoplama(i));
    foreach (var item in ss.products.Data)
    {
        name = item.attributes.name;

    }

}
