var map;
var layer_abusosSexuales;
var layer_amenazas;
var layer_automotores;
var layer_homicidios;
var layer_homicidiosCulposos;
var layer_hurto;
var layer_lesiones;
var layer_lesionesCulposas;
var layer_robos;
var layer_violenciasDeGeneros;
var layer_violenciasFamiliares;


$(document).ready(function () {
    map = new OpenLayers.Map('mapa');
    var wms = new OpenLayers.Layer.WMS("OpenLayers WMS",
        "http://vmap0.tiles.osgeo.org/wms/vmap0", { layers: 'basic' });
    map.addLayer(wms);
    map.zoomToMaxExtent();


    $('#altaForm').on('submit', function (e) {
        e.preventDefault();
        $('#Latitud').val(autocomplete.getPlace().geometry.location.lat());
        $('#Longitud').val(autocomplete.getPlace().geometry.location.lng());
        this.submit();
    });

    $("#Cb_abusosSexuales").click(function () {
        if ($("#Cb_abusosSexuales").is(':checked')) {
            layer_abusosSexuales = new OpenLayers.Layer.WMS('Rezoning Scenario',
                       'http://localhost:8080/geoserver/Proyecto/wms',
                        { 'layers': 'Proyecto:Abusos Sexuales' , transparent: true},
                        {   isBaseLayer: false,
                            projection: 'EPSG:900913'
                }
	);
            map.addLayer(layer_abusosSexuales);
        } else {
            map.removeLayer(layer_abusosSexuales);
        }
    });
    $("#Cb_amenazas").click(function () {
        if ($("#Cb_amenazas").is(':checked')) {
            layer_amenazas = new OpenLayers.Layer.WMS('Rezoning Scenario',
                       'http://localhost:8080/geoserver/Proyecto/wms',
                        { 'layers': 'Proyecto:Amenazas', transparent: true },
                        {
                            isBaseLayer: false,
                            projection: 'EPSG:900913'
                        }
	);
            map.addLayer(layer_amenazas);
        } else {
            map.removeLayer(layer_amenazas);
        }
    });
    $("#Cb_automotores").click(function () {
        if ($("#Cb_automotores").is(':checked')) {
            layer_automotores = new OpenLayers.Layer.WMS('Rezoning Scenario',
                       'http://localhost:8080/geoserver/Proyecto/wms',
                        { 'layers': 'Proyecto:Automotores', transparent: true },
                        {
                            isBaseLayer: false,
                            projection: 'EPSG:900913'
                        }
	);
            map.addLayer(layer_automotores);
        } else {
            map.removeLayer(layer_automotores);
        }
    });
    $("#Cb_homicidios").click(function () {
        if ($("#Cb_homicidios").is(':checked')) {
            layer_homicidios = new OpenLayers.Layer.WMS('Rezoning Scenario',
                       'http://localhost:8080/geoserver/Proyecto/wms',
                        { 'layers': 'Proyecto:Homicidios', transparent: true },
                        {
                            isBaseLayer: false,
                            projection: 'EPSG:900913'
                        }
	);
            map.addLayer(layer_homicidios);
        } else {
            map.removeLayer(layer_homicidios);
        }
    });
    $("#Cb_homicidiosCulposos").click(function () {
        if ($("#Cb_homicidiosCulposos").is(':checked')) {
            layer_homicidiosCulposos = new OpenLayers.Layer.WMS('Rezoning Scenario',
                       'http://localhost:8080/geoserver/Proyecto/wms',
                        { 'layers': 'Proyecto:Homicidios Culposos', transparent: true },
                        {
                            isBaseLayer: false,
                            projection: 'EPSG:900913'
                        }
	);
            map.addLayer(layer_homicidiosCulposos);
        } else {
            map.removeLayer(layer_homicidiosCulposos);
        }
    });
    $("#Cb_hurto").click(function () {
        if ($("#Cb_hurto").is(':checked')) {
            layer_hurto = new OpenLayers.Layer.WMS('Rezoning Scenario',
                       'http://localhost:8080/geoserver/Proyecto/wms',
                        { 'layers': 'Proyecto:Hurto', transparent: true },
                        {
                            isBaseLayer: false,
                            projection: 'EPSG:900913'
                        }
	);
            map.addLayer(layer_hurto);
        } else {
            map.removeLayer(layer_hurto);
        }
    });
    $("#Cb_lesiones").click(function () {
        if ($("#Cb_lesiones").is(':checked')) {
            layer_lesiones = new OpenLayers.Layer.WMS('Rezoning Scenario',
                       'http://localhost:8080/geoserver/Proyecto/wms',
                        { 'layers': 'Proyecto:Lesiones', transparent: true },
                        {
                            isBaseLayer: false,
                            projection: 'EPSG:900913'
                        }
	);
            map.addLayer(layer_lesiones);
        } else {
            map.removeLayer(layer_lesiones);
        }
    });
    $("#Cb_lesionesCulposas").click(function () {
        if ($("#Cb_lesionesCulposas").is(':checked')) {
            layer_lesionesCulposas = new OpenLayers.Layer.WMS('Rezoning Scenario',
                       'http://localhost:8080/geoserver/Proyecto/wms',
                        { 'layers': 'Proyecto:Lesiones Culposas', transparent: true },
                        {
                            isBaseLayer: false,
                            projection: 'EPSG:900913'
                        }
	);
            map.addLayer(layer_lesionesCulposas);
        } else {
            map.removeLayer(layer_lesionesCulposas);
        }
    });
    $("#Cb_robos").click(function () {
        if ($("#Cb_robos").is(':checked')) {
            layer_robos = new OpenLayers.Layer.WMS('Rezoning Scenario',
                       'http://localhost:8080/geoserver/Proyecto/wms',
                        { 'layers': 'Proyecto:Robos', transparent: true },
                        {
                            isBaseLayer: false,
                            projection: 'EPSG:900913'
                        }
	);
            map.addLayer(layer_robos);
        } else {
            map.removeLayer(layer_robos);
        }
    });
    $("#Cb_violenciasDeGeneros").click(function () {
        if ($("#Cb_violenciasDeGeneros").is(':checked')) {
            layer_violenciasDeGeneros = new OpenLayers.Layer.WMS('Rezoning Scenario',
                       'http://localhost:8080/geoserver/Proyecto/wms',
                        { 'layers': 'Proyecto:Violencias de generos', transparent: true },
                        {
                            isBaseLayer: false,
                            projection: 'EPSG:900913'
                        }
	);
            map.addLayer(layer_violenciasDeGeneros);
        } else {
            map.removeLayer(layer_violenciasDeGeneros);
        }
    });
    $("#Cb_violenciasFamiliares").click(function () {
        if ($("#Cb_violenciasFamiliares").is(':checked')) {
            layer_violenciasFamiliares = new OpenLayers.Layer.WMS('Rezoning Scenario',
                       'http://localhost:8080/geoserver/Proyecto/wms',
                        { 'layers': 'Proyecto:Violencias Familiares', transparent: true },
                        {
                            isBaseLayer: false,
                            projection: 'EPSG:900913'
                        }
	);
            map.addLayer(layer_violenciasFamiliares);
        } else {
            map.removeLayer(layer_violenciasFamiliares);
        }
    });
});

