import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable()
export class TestService {
  constructor(protected http: HttpClient) {
  }

  test(): Observable<string> {
    return this.http.get('https://localhost:5001/test', {responseType: 'text', withCredentials: true});
  }
}
