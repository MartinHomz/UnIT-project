import"./esm-chunk-d81494b9.js";import{setInputAttribute as e,ensureElement as t,getParentByClassName as o,attachEventToElement as n,elementIsInDOM as s,detachEventFromElement as r}from"./esm-dom-utils-88a2c0cb.js";import{d as c,r as u}from"./esm-chunk-fc46b9cc.js";import{T as i}from"./esm-chunk-639f7231.js";import{K as a}from"./esm-chunk-54fd5426.js";import{getDropDownElement as d,onOutsideClick as l,isDropDownVisible as m}from"./esm-dropdowns-86a28ee6.js";import"./esm-chunk-13e2cf5f.js";import{scrollToFocusedItem as f,getParametersForVirtualScrollingRequest as p}from"./esm-grid-3284ddda.js";import"./esm-popup-utils-20f67cc2.js";import"./esm-focus-utils-eb2e3d52.js";import"./esm-chunk-5d9ef2cd.js";import"./esm-dragAndDropUnit-ce1d0bbc.js";import{k,a as y}from"./esm-chunk-0a0b72b5.js";function g(e){const t=d(e);f(t)}function v(t,o,n){e(t,"value",o),h(t),n&&function(e){e&&e.select()}(t)}function h(e){e.previousSibling.innerText=""===e.value&&e.placeholder?e.placeholder:e.value}function C(e){e=t(e),document.activeElement===e&&E(e)}function b(e,t){const n=e.target;T(n,!0),function(e){if(e){const t=o(e,"form-control");t.dataset.bluredClass&&(t.className=t.dataset.bluredClass)}}(n),n.dataset.timerId=setTimeout((function(){if(delete n.dataset.timerId,document.activeElement!==n)try{D(t,n)}catch(e){}}),200)}function T(e,t){e.dataset.timerId&&(clearTimeout(e.dataset.timerId),delete e.dataset.timerId),t||setTimeout((function(){T(e,!0)}),100)}function E(e){if(e){const t=o(e,"form-control");t.dataset.focusedClass&&(t.className=t.dataset.focusedClass)}}function j(e,t){return t&&k(e),function(e){return I(e)||e.keyCode===a.Enter}(e)&&(e.stopPropagation(),e.preventDefault()),!1}function w(e,t,o,n,s){let r=!1;if(n&&(r=r||y(e)),r=r||function(e){const t=e.altKey&&(e.keyCode===a.Down||e.keyCode===a.Up),o=I(e),n=e.keyCode===a.Esc||e.keyCode===a.Enter,s=function(e){const t=0===e.target.value.length;return e.keyCode===a.Backspace&&t}(e);return t||o||n||s}(e),r){const n=e.target.value,r=""!==e.target.dataset.previousValue;if(o&&s){const s=o.querySelector(".dxgvCSD");s&&(o=s);const c=p(o,!1);t.invokeMethodAsync("OnTagBoxListBoxKeyUp",n,e.keyCode,e.altKey,e.ctrlKey,c.requestScrollState.itemHeight,c.requestScrollState.scrollTop,c.requestScrollState.scrollHeight,r)}else t.invokeMethodAsync("OnTagBoxKeyUp",n,e.keyCode,e.altKey,e.ctrlKey,r)}}function I(e){return e.keyCode===a.Down||e.keyCode===a.Up||e.keyCode===a.PageUp||e.keyCode===a.PageDown||e.ctrlKey&&(e.keyCode===a.Home||e.keyCode===a.End)}function D(e,t,o){if(!t)return;const n=(new Date).getTime();t.dataset.lastLostFocusTime&&n-t.dataset.lastLostFocusTime<300&&!o||(t.dataset.lastLostFocusTime=(new Date).getTime(),document.activeElement!==t&&(t.value=""),e.invokeMethodAsync("OnTagBoxLostFocus",t.value))}function S(e,o,a){const f=t(e);if(!f)return;c(f);const p=t(o.inputElement),k=d(f),y=function(e){return j(e,o.filteringEnabled)},g=function(e){return w(e,a,k,o.filteringEnabled,o.virtualScrollingEnabled)},v=function(e){return function(e,t){E(e.target)}(e)},C=function(e){return b(e,a)},I=function(e){return h(e.target)},S=function(e){return T(p)},K=function(e){return l(e,f,(function(){s(f)||c(f);const e=document.activeElement===p,t=p.dataset.timerId>0,o=k&&m(k);T(p),(e||t||o)&&D(a,p,!0)}))};return n(p,"keydown",y),n(p,"keyup",g),n(p,"focus",v),n(p,"blur",C),n(p,"input",I),n(f,"mousedown",S),n(document,i.touchMouseDownEventName,K),u(f,(function(){r(p,"keydown",y),r(p,"keyup",g),r(p,"focus",v),r(p,"blur",C),r(p,"input",I),r(f,"mousedown",S),r(document,i.touchMouseDownEventName,K)})),h(p),Promise.resolve("ok")}function K(e){if(e=t(e))return c(e),Promise.resolve("ok")}const x={init:S,dispose:K,prepareInputIfFocused:C,scrollToFocusedItem:g,fitInputWidth:h,forceInputValue:v};export default x;export{K as dispose,h as fitInputWidth,v as forceInputValue,S as init,C as prepareInputIfFocused,g as scrollToFocusedItem};