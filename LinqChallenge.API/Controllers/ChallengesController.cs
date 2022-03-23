using LinqChallenge.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LinqChallenge.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ChallengesController : ControllerBase
{
    // Bu method, contacts nesnesni içerisindeki benzersiz şehirlerin listesini List<string> olarak dönmelidir
    [HttpGet("1")]
    public IActionResult Challenge_1()
    {
        var contacts = new List<ContactInformation>
        {
            new() { Name = "Ahmet", InformationValue = "Ankara"},
            new() { Name = "Mehmet", InformationValue = "Ankara"},
            new() { Name = "Ayşe", InformationValue = "Mersin"},
            new() { Name = "Hasan", InformationValue = "Adana"},
            new() { Name = "Kemal", InformationValue = "Antalya"},
            new() { Name = "İsmail", InformationValue = "Antalya"},
        };

        var uniqueCities = new List<string>();
        // TODO: Buradan itibaren düzenleme yapın

        // -- Buraya kadar

        return Ok(uniqueCities);
    }

    // Belirtilen kod bloğunu tek satıra inecek şekilde linq kullanarak refactor ediniz
    [HttpGet("2")]
    public IActionResult Challenge_2()
    {
        var list = new List<ContactInformation>
        {
            new() { Id = 1, Name = "Ahmet", InformationValue = "Ankara"},
            new() { Id = 1, Name = "Ahmet", InformationValue = "Ankara"},
            new() { Id = 2, Name = "Ayşe", InformationValue = "Mersin"},
            new() { Id = 3, Name = "Hasan", InformationValue = "Adana"},
            new() { Id = 4, Name = "Kemal", InformationValue = "Antalya"},
            new() { Id = 4, Name = "Kemal", InformationValue = "Antalya"},
            new() { Id = 5, Name = "Ahmet", InformationValue = "Antalya"},
        };

        // TODO: Buradan itibaren düzenleme yapın
        int i = 0;
        List<ContactInformation> distinctElements = new List<ContactInformation>();
        while (i < list.Count)
        {
            if (distinctElements.All(p => p.Id != list[i].Id))
                distinctElements.Add(list[i]);
            i++;
        }
        // -- Buraya kadar

        return Ok(distinctElements);
    }

    // Bu method, bir ildeki Kişi Sayısı ve Telefon Numarası sayısı verilerini geri dönmelidir.
    // Örn: Antalya, PersonCount: 2, PhoneNumberCount: 2
    [HttpGet("3")]
    public IActionResult Challenge_3()
    {
        var informations = new List<ContactInformation>()
        {
            new() { PersonId = 1, Name = "Ahmet", InformationType = InformationType.Address, InformationValue = "Ankara"},
            new() { PersonId = 1, Name = "Ahmet", InformationType = InformationType.PhoneNumber, InformationValue = "111-111-111"},
            new() { PersonId = 2, Name = "Ayşe", InformationType = InformationType.Address, InformationValue = "Mersin"},
            new() { PersonId = 3, Name = "Hasan", InformationType = InformationType.Address, InformationValue = "Adana"},
            new() { PersonId = 4, Name = "Kemal", InformationType = InformationType.Address, InformationValue = "Antalya"},
            new() { PersonId = 4, Name = "Kemal", InformationType = InformationType.PhoneNumber, InformationValue = "222-222-222"},
            new() { PersonId = 5, Name = "Ahmet", InformationType = InformationType.Address, InformationValue = "Antalya"},
            new() { PersonId = 5, Name = "Ahmet", InformationType = InformationType.PhoneNumber, InformationValue = "333-333-333"},
        };

        // TODO: Buradan itibaren düzenleme yapın
        var data = new List<LocationDto>();

        // -- Buraya kadar

        return Ok(data);
    }

    // Bu method listedeki en küçük sayı hariç diğer tüm elemanları dönmelidir
    [HttpGet("4")]
    public IActionResult Challenge_4()
    {
        var numbers = new List<int>
        {
            1, 30, 40, 20, -10, 60
        };

        // TODO: Buradan itibaren düzenleme yapın
        var data = numbers;

        // -- Buraya kadar

        return Ok(data.ToList());
    }

    // Bu method text değişkenindeki tekrar etmeyen ilk karakteri geri dönmelidir
    // Örneğin: moonmen için: m tekrar ediyor, o tekrar ediyor, n tekrar ediyor, e tekrar etmiyor; öyleyse e dönmeli
    [HttpGet("5")]
    public IActionResult Challenge_5()
    {
        var text = "moonmen";

        // TODO: Buradan itibaren düzenleme yapın
        var ilkTekrarEtmeyenKarakter = text;

        // -- Buraya kadar

        return Ok(ilkTekrarEtmeyenKarakter.ToString());
    }
}
