import { Component, Inject, ViewChild, ElementRef } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[] = [];
  searchTerm: string = '';
  uploadedFile: File | null = null;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<WeatherForecast[]>(baseUrl + 'ListarDocumentos').subscribe(result => {
      this.forecasts = result;
      console.log(this.forecasts);
    }, error => console.error(error));
  }
  filteredItems(): WeatherForecast[] {
    return this.forecasts.filter(forecasts =>
      forecasts.nomeDocumento.toString()
                            .toLowerCase()
                            .includes(this.searchTerm.toLowerCase())
    );
  }
  @ViewChild('fileInput') fileInput!: ElementRef<HTMLInputElement>; // Referência ao campo de upload
  handleFileInput(event: any) {
    this.uploadedFile = event.target.files[0];
    const newItem: WeatherForecast = {
      temperatureC: this.forecasts.length + 1,
      summary: `Novo Item ${this.forecasts.length + 1}`,
      nomeDocumento: this.uploadedFile ? this.uploadedFile.name : '',
      dataAlteracao: new Date().toDateString()
    };
    this.forecasts.push(newItem);
    this.uploadedFile = null; // Limpa o arquivo após adicionar
  }
  addItem() {
    
  }

}

interface WeatherForecast {
  dataAlteracao: string;
  temperatureC: number;
  nomeDocumento: string;
  summary: string;
}
