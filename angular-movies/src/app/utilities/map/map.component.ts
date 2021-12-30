import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { tileLayer, LeafletMouseEvent, latLng, Marker, marker } from 'leaflet';
import { coordinatesMap, coordinatesMapWithMessage } from './coordinate';

@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.css']
})
export class MapComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
    this.layers = this.initialCoordinates.map((value) => {
      const m = marker([value.latitude, value.longitude]);
      if (value.message){
        m.bindPopup(value.message, {autoClose: false, autoPan: false});
      }
      return m;
    });
  }

  @Input()
  initialCoordinates: coordinatesMapWithMessage [] = [];

  @Input()
  editMode: boolean = true;

  @Output()
  onSelectedLocation = new EventEmitter<coordinatesMap>();

  options = {
    layers: [
      tileLayer('http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', { maxZoom: 18, 
      attribution: 'Angular Movies' })
    ],
    zoom: 14,
    center: latLng(43.84585585279759, 18.38150024414063)
  };
  layers: Marker<any>[] = [];
  handleMapClick(event: LeafletMouseEvent){
    if(this.editMode){
    const latitude = event.latlng.lat;
    const longitude = event.latlng.lng;
    console.log({latitude},{longitude});
    this.layers = [];
    this.layers.push(new Marker([latitude, longitude]));
    this.onSelectedLocation.emit({latitude, longitude});
  }
  
  }
}
