
const tabela = document.getElementById('tabelaPojazdow');
const btnZapisz = document.getElementById('btnZapisz');
const formularz = document.getElementById('formularzPojazdu');


const modalElement = document.getElementById('modalDodaj');
const myModal = new bootstrap.Modal(modalElement);


let edytowanyWiersz = null;


btnZapisz.addEventListener('click', function() {
    
    
    const nrRej = document.getElementById('nrRej').value.toUpperCase();
    const marka = document.getElementById('marka').value;
    const model = document.getElementById('model').value;
    const rok = document.getElementById('rok').value;
    const wlasciciel = document.getElementById('wlasciciel').value;

    
    if (!nrRej || !marka || !wlasciciel) {
        alert("Błąd: Musisz podać Nr rejestracyjny, Markę i Właściciela!");
        return;
    }

    const obecnyRok = new Date().getFullYear();
    if (rok < 1900 || rok > obecnyRok + 1) {
        alert(`Błąd: Rok produkcji musi być w przedziale 1900 - ${obecnyRok + 1}`);
        return;
    }

    if (nrRej.length < 3) {
        alert("Błąd: Numer rejestracyjny jest za krótki!");
        return;
    }

    
    
    if (edytowanyWiersz) {
        
        edytowanyWiersz.cells[0].innerHTML = `<strong>${nrRej}</strong>`;
        edytowanyWiersz.cells[1].innerText = marka;
        edytowanyWiersz.cells[2].innerText = model;
        edytowanyWiersz.cells[3].innerText = rok;
        edytowanyWiersz.cells[4].innerText = wlasciciel;

        
        edytowanyWiersz = null; 
        
        
        document.querySelector('.modal-title').innerText = "Dodaj Nowy Pojazd";

    } else {
        
        const nowyWiersz = document.createElement('tr');
        
        nowyWiersz.innerHTML = `
            <td><strong>${nrRej}</strong></td>
            <td>${marka}</td>
            <td>${model}</td>
            <td>${rok}</td>
            <td>${wlasciciel}</td>
            <td>
                <button class="btn btn-sm btn-warning me-2 btn-edytuj">Edytuj</button>
                <button class="btn btn-sm btn-danger btn-usun">Usuń</button>
            </td>
        `;
        tabela.appendChild(nowyWiersz);
    }

    
    formularz.reset(); 
    myModal.hide(); 
});


tabela.addEventListener('click', function(e) {
    
   
    if (e.target.classList.contains('btn-usun')) {
        if (confirm("Czy na pewno chcesz usunąć ten pojazd?")) {
            e.target.closest('tr').remove();
        }
    }

   
    if (e.target.classList.contains('btn-edytuj')) {
       
        const wiersz = e.target.closest('tr');
        
        
        const nrRej = wiersz.cells[0].innerText;
        const marka = wiersz.cells[1].innerText;
        const model = wiersz.cells[2].innerText;
        const rok = wiersz.cells[3].innerText;
        const wlasciciel = wiersz.cells[4].innerText;

        
        document.getElementById('nrRej').value = nrRej;
        document.getElementById('marka').value = marka;
        document.getElementById('model').value = model;
        document.getElementById('rok').value = rok;
        document.getElementById('wlasciciel').value = wlasciciel;

        
        edytowanyWiersz = wiersz;

        document.querySelector('.modal-title').innerText = "Edytuj Pojazd";
        myModal.show();
    }
});


const btnGlownyDodaj = document.querySelector('[data-bs-target="#modalDodaj"]');
btnGlownyDodaj.addEventListener('click', function() {
    formularz.reset();
    edytowanyWiersz = null;
    document.querySelector('.modal-title').innerText = "Dodaj Nowy Pojazd";
});